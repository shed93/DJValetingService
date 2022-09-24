import React, { Component } from 'react';

export class Counter extends Component {
    static displayName = Counter.name;

    constructor(props) {
        super(props);
        this.state = {
        };
        this.submit = this.submitForm.bind(this);
    }

    submitForm() {
        this.setState({
        });
    }

    render() {
        return (
            <div>
                <h1>DJ Valeting Form</h1>
                <form action="/ValetingRequest/SubmitClientBookingRequest">
                    <label for="fname">First name:</label><br />
                    <input type="text" id="fname" name="fname" value="John" />
                    <br />
                    <label for="lname">Last name:</label>
                    <br />
                    <input type="text" id="lname" name="lname" value="Doe" />
                    <br />
                    <br />
                    <input type="submit" value="Submit" />
                </form>
            </div>
        );
    }
}
