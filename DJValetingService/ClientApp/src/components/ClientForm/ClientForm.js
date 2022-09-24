import React, { Component } from 'react';

export class ClientForm extends Component {
    static displayName = ClientForm.name;

    constructor(props) {
        super(props);
        this.state = {
            vehicleSizes: [],
        };
        this.submit = this.submitForm.bind(this);
        this.getVehicleSizes();
    }

    submitForm(e) {
        e.preventDefault();
    }

    render() {
        return (
            <div>
                <h1>DJ Valeting Form</h1>
                <form onSubmit={this.submit}>
                    <label htmlFor="fname">First name:</label><br />
                    <input type="text" id="name" name="name" ref={(name) => this.name = name} />
                    <br />
                    <br />
                    <input type="submit" value="Submit" />
                </form>
            </div>
        );
    }
    async getVehicleSizes() {
        const response = await fetch(`ValetingRequest/GetVehicleSizes`);
        const data = await response.json();
        this.setState({ vehicleSizes: data });
    }
}
