import React from 'react';
import './Edit.scss';
import {api} from "../../../../../services/api";
import {getProductsUrlByName, EDIT_PRODUCT_URL, getProductUrlForDelete} from "../../../../../services/urls/productUrls";
import Pagination from 'react-js-pagination';
import {Spinner} from "../../../../Spinner/Spinner";

const howProductsPerPage = 5;

class Edit extends React.Component {
	constructor(props) {
		super(props);
		this.state = {
			searchValue: '',
			products: [],
			activePage: 1,
			totalProductCount: 0,
			selectedProduct: null,
			newProductName: '',
			newProductPrice: 0,
			isLoading: false,
			isLoaded: true,
			isDeleteConfirmed: false
		}
	}

	onChangeSearch = e => {
		if (!e.target.value) {
			this.setState({
				products: [],
				searchValue: ''
			});
			return;
		}

		this.setState({searchValue: e.target.value});
		api()
			.get(getProductsUrlByName(e.target.value, this.state.activePage, howProductsPerPage))
			.then(resp => {
				console.log(resp.data);
				this.setState({
					products: resp.data.data,
					activePage: resp.data.pageNumber,
					totalProductCount: resp.data.totalCount
				});
			})
	};

	onProductClick = item => {
		this.setState({
			selectedProduct: item,
			newProductName: item.name,
			newProductPrice: item.price,
		});
	};

	onPaginationChange = (pageNumber) => {
		api()
			.get(getProductsUrlByName(this.state.searchValue, pageNumber, howProductsPerPage))
			.then(resp => {
				console.log(resp.data);
				this.setState({
					products: resp.data.data,
					activePage: resp.data.pageNumber,
					totalProductCount: resp.data.totalCount
				});
			})
	};

	onSaveProduct = () => {
		if (this.state.isLoaded) {
			this.setState({isLoaded: false});
		}
		this.setState({isLoading: true});
		const newProduct = {
			productId: this.state.selectedProduct.id,
			name: this.state.newProductName,
			price: this.state.newProductPrice
		};
		api()
			.put(EDIT_PRODUCT_URL, newProduct)
			.then(resp => {
				console.log(resp.data);
				this.setState({
					isLoading: false,
					isLoaded: true
				});
				alert("Дані успішно оновлено");
			})
			.catch(err => {
				console.error(err.response.data);
			});
	};

	onDeletePruduct = () => {
		if (this.state.isLoaded) {
			this.setState({isLoaded: false});
		}
		this.setState({isLoading: true});
		api()
			.delete(getProductUrlForDelete(this.state.selectedProduct.id))
			.then(resp => {
				console.log('resp data', resp.data);
				if (resp.data >= 1) {
					this.setState({
						isLoading: false,
						isLoaded: true,
						isDeleteConfirmed: false
					});
					this.onCloseEditPanel();
					alert('Товар видалено успішно');
				}
			})
			.catch(err => console.error(err.response.data));
	};

	onCloseEditPanel = () => {
		this.setState({
			selectedProduct: null,
			products: []
		});
		this.onChangeSearch({
			target: {
				value: this.state.searchValue
			}
		})
	};

	renderEditPanel = () => {
		const {selectedProduct} = this.state;
		return (
			<div>
				{this.state.isLoaded && !this.state.isLoading ? <table>
					<thead className="table-head">
					<tr>
						<th>Назва властивості</th>
						<th>Значення властивості</th>
					</tr>
					</thead>
					<tbody>
					<tr>
						<td>Назва</td>
						<td>
							<input className="form-control" placeholder="Введіть назву продукту"
								   defaultValue={selectedProduct.name}
								   value={this.state.newProductName}
								   onChange={(e) => this.setState({newProductName: e.target.value})
								   }/>
						</td>
					</tr>
					<tr>
						<td>Ціна</td>
						<td>
							<input className="form-control" placeholder="Введіть назву продукту"
								   defaultValue={selectedProduct.price}
								   value={this.state.newProductPrice}
								   onChange={(e) => this.setState({newProductPrice: e.target.value})}/>
						</td>
					</tr>
					<tr>
						<td>
							<button className="btn btn-info" onClick={this.onSaveProduct}>Зберети</button>
						</td>
						<td>
							<button className="btn btn-danger" onClick={this.onCloseEditPanel}>Закрити</button>
						</td>
					</tr>
					<tr>
						<td>
							<button className="btn btn-warning"
									disabled={!this.state.isDeleteConfirmed}
									onClick={this.onDeletePruduct}>Видалити
							</button>
						</td>
						<td>
							<div>Ви впевнені що хочете видалити даний товар</div>
							<input type="checkbox"
								   onChange={() => this.setState(prev => ({isDeleteConfirmed: !prev.isDeleteConfirmed}))}/>
						</td>
					</tr>
					</tbody>
				</table> : <Spinner/>}
			</div>
		);
	};

	render() {
		return (
			<div className="edit-container">
				<div className="edit-container__header">
					Редактор товару
				</div>
				<div className="edit-container__search-box">
					<h6 className="text-center">Пошук</h6>
					<input className="form-control"
						   placeholder="Пошук товару"
						   onChange={this.onChangeSearch}
						   value={this.state.searchValue}/>
				</div>
				{!this.state.selectedProduct ? <div>
					<div className="edit-container__product-list-box">
						{this.state.products.length > 0 && <h6 className="text-center">Оберіть товар</h6>}
						<ul className="list-group edit-container__product-list-box__list-group">
							{
								this.state.products.map(item => <li key={item.id}
																	className="list-group-item list-group edit-container__product-list-box__list-group__item"
																	onClick={() => this.onProductClick(item)}>
									<div>{`Назва продукту: ${item.name}`}</div>
									<div>{`Категорія: ${item.category}`}</div>
									<div>{`Підкатегорія: ${item.subCategory}`}</div>
								</li>)
							}
						</ul>
					</div>
					<div className="edit-container__pagin-box">
						{this.state.products.length > 0 && <Pagination totalItemsCount={this.state.totalProductCount}
																	   itemsCountPerPage={16}
																	   onChange={this.onPaginationChange}
																	   activePage={this.state.activePage}
																	   itemClass="page-item"
																	   linkClass="page-link"
																	   innerClass="edit-container__pagin-box__pagin pagination"/>}
					</div>
				</div> : this.renderEditPanel()}
			</div>
		)
	}
}

export default Edit;