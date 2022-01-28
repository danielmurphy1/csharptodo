import React from 'react';
import { ListGroup, InputGroup, Button, Container } from 'react-bootstrap';

function ToDoList(){
    return(
        //try redering each li as a "button" (as per react-bootstrap docs)
        // <ListGroup as="ul" variant="flush">
        //     <ListGroup.Item as="li" className="d-flex justify-content-center align-items-end border border-danger w-50 mx-auto">
        //         <InputGroup.Checkbox className="border border-danger"/>
        //         <span className="mx-3 border border-danger">Run</span>
        //         <Button className="btn btn-danger mx-3 border border-primary">Delete</Button>
        //     </ListGroup.Item>
        //     <ListGroup.Item as="li" className="d-flex justify-content-center align-items-end border border-danger">
        //         <InputGroup.Checkbox className="border border-danger"/>
        //         <span className="mx-3 border border-danger">Go Food Shopping</span>
        //         <Button className="btn btn-danger mx-3 border border-primary">Delete</Button>
        //     </ListGroup.Item>
        // </ListGroup>

        <ListGroup as="ul" variant="flush" className="w-50 mx-auto">
            <ListGroup.Item className="d-flex justify-content-between align-items-end">
                <InputGroup.Checkbox />
                <span className="mx-3 w-100">Run</span>
                <Button className="btn btn-danger">Delete</Button>
            </ListGroup.Item>
            <ListGroup.Item className="d-flex justify-content-between align-items-end">
                <InputGroup.Checkbox />
                <span className="mx-3 w-100">Go Food Shopping and then walk the dog around the block</span>
                <Button className="btn btn-danger">Delete</Button>
            </ListGroup.Item>
        </ListGroup>
    );
};

export default ToDoList;