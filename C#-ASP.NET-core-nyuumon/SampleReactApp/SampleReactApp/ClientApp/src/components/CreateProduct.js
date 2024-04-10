import React, { useState } from 'react';

export function CreateProduct() {
    const accesUrl = 'https://localhost:7070/api/Products';
    const [name, setName] = useState("");
    const [price, setPrice] = useState(0);
    const [desc, setDesc] = useState("");

    const doName = (event) => {
        setName(event.target.value);
    }
    const doPrice = (event) => {
        setPrice(event.target.value);
    }
    const doDesc = (event) => {
        setDesc(event.target.value);
    }
    const doCreate = async (event) => {
        const data = { Name: name, Price: price, Description: desc }
        const response = await fetch(accesUrl, {
            method: "POST",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(data)
        });
        if (response.ok) {
            alert("Create Product data!");
            setName("");
            setPrice(0);
            setDesc("");
        } else {
            alert("ERROR is occurred...");
        }
    }

    const renderForm = () => {
        return (
            <div>
                <label>Name:</label>
                <input type="text" className="form-control" onChange={doName} value={name} />
                <label>Price</label>
                <input type="number" className="form-control" onChange={doPrice} value={price} />
                <label>Description</label>
                <input type="text" className="form-control" onChange={doDesc} value={desc} />
                <button className="btn-primary my-3" onClick={doCreate}>Create</button>
            </div>
        );
    }

    return (
        <div>
            <h1 id="tableLabel">Product List</h1>
            <p>Fetcing data from the server...</p>
            {renderForm()}
        </div>
    );
}