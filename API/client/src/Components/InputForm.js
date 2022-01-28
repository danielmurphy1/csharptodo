import React from 'react';
import { Form, InputGroup, Button } from 'react-bootstrap';

function InputForm(){
    return(
        <Form className="w-50 m-auto">
            <InputGroup >
                <Form.Control type="text" className="me-3" placeholder="Enter To Do Item" required/>
                <Button>Add To Do</Button>
            </InputGroup>
        </Form>
    );
};

export default InputForm;