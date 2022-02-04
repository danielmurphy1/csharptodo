import React from 'react';
import { ListGroup, InputGroup, Button, Container } from 'react-bootstrap';

function ToDoList(props){
    console.log(props.todos)
    let todos = props.todos.map(todo =>{
        return <ListGroup.Item className="d-flex justify-content-between align-items-end" key={todo.id}>
                    <InputGroup.Checkbox checked={todo.isComplete} value={todo.isComplete} onChange={(e) => props.handleCheckboxClick(todo.id, e.target.checked)}/>
                    <span className="mx-3 w-100">{todo.text}</span>
                    <Button className="btn btn-danger">Delete</Button>
                </ListGroup.Item>
    })

    return(
        // <ListGroup as="ul" variant="flush" className="w-50 mx-auto">
        //     <ListGroup.Item className="d-flex justify-content-between align-items-end">
        //         <InputGroup.Checkbox />
        //         <span className="mx-3 w-100">Run</span>
        //         <Button className="btn btn-danger">Delete</Button>
        //     </ListGroup.Item>
        //     <ListGroup.Item className="d-flex justify-content-between align-items-end">
        //         <InputGroup.Checkbox />
        //         <span className="mx-3 w-100">Go Food Shopping and then walk the dog around the block</span>
        //         <Button className="btn btn-danger">Delete</Button>
        //     </ListGroup.Item>
        // </ListGroup>
        <ListGroup as="ul" variant="flush" className="w-50 mx-auto">
            {todos}
        </ListGroup>
    );
};

export default ToDoList;