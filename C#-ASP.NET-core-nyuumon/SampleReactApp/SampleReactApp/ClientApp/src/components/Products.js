import React, { Component } from 'react';

export class Products extends Component {
    static accesUrl = 'https://localhost:7070/api/Products';

    constructor(props) {
        super(props);
        this.state = { products: [], loading: true };
    }

    componentDidMount() {
        this.getProductsData();
    }

    static renderProductsTable(products) {
        return (
            <table className="table">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Price</th>
                        <th>Desc.</th>
                    </tr>
                </thead>
                <tbody>
                    {products.map(product =>
                        <tr key={product.ProductId}>
                            <td>{product.name}</td>
                            <td>{product.price}</td>
                            <td>{product.description}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        return(
            <div>
                <h1 id="tableLabel">Products list</h1>
                <p>Fetching data from the server...</p>
                {this.state.loding
                    ? <p>Loading...</p>
                    : Products.renderProductsTable(this.state.products)
                }
            </div>
        );
    }

    async getProductsData() {
        const response = await fetch(Products.accesUrl);
        const data = await response.json();
        this.setState({ products: data, loding: false });
    }
}