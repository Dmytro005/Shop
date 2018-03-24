import React from 'react';

const getCategory = (props) => props.match.params.category;
const getSubCategory = (props) => props.match.params.subCategory;

class ProductPlace extends React.Component {
	render() {
		return (
			<div>
				<div>{getCategory(this.props)}</div>
				<div>{getSubCategory(this.props)}</div>
			</div>
		);
	}
}

export default ProductPlace;