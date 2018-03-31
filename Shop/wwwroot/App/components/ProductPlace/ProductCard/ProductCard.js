import React from 'react';
import './ProductCard.scss';

class ProductCard extends React.Component {
	constructor(props) {
		super(props);
		this.state = {
			inProductCardTextBut: 'В кошик',
			isEnableInProductCardBut: true
		}
	}

	onProductCardButClick = (e) => {
		// todo need fix 'if user can revert product'
		if (this.state.inProductCardTextBut !== 'Добавлено') {
			this.setState((prev) => ({
				inProductCardTextBut: 'Добавлено',
				isEnableInProductCardBut: !prev.isEnableInProductCardBut
			}));
		}
		this.props.onProductCardButClick(e, this.props.product.id);
	};

	onLikeButClick = (e) => {
		this.props.onLikeButClick(e, this.props.product.id);
	};

	render() {
		return (
			<div className="card">
				<img className="card-img-top"
					 src="https://pbs.twimg.com/profile_images/473506797462896640/_M0JJ0v8_400x400.png"
					 alt="Card image cap"/>
				<div className="card-body">
					<h5 className="card-title text-center">{this.props.product.name}</h5>
					<h6 className="text-center">{`${this.props.product.price} грн`}</h6>
					<div className="card__footer">
						<button className="btn btn-primary"
								onClick={this.onProductCardButClick}
								disabled={!this.state.isEnableInProductCardBut}>{this.state.inProductCardTextBut}</button>
						<button className="btn btn-info" onClick={this.onLikeButClick}>В обране</button>
					</div>
				</div>
			</div>
		);
	}
}

export default ProductCard;