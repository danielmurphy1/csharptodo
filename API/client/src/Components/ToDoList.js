import React from 'react';
import { ListGroup, InputGroup, Button } from 'react-bootstrap';

function ToDoList(props){
    let todos = props.todos.map(todo =>{
        return <ListGroup.Item className="d-flex justify-content-between align-items-end" key={todo.id}>
                    <InputGroup.Checkbox 
                        checked={todo.isComplete} 
                        value={todo.isComplete} 
                        onChange={(e) => props.handleCheckboxClick(todo.id, e.target.checked)}
                    />
                    <span className={`mx-3 w-100 ${todo.isComplete && 'line-through'}`} >{todo.text}</span>
                    <Button className="btn btn-danger" onClick={() => props.handleDeleteToDo(todo.id)} disabled={!todo.isComplete}>Delete</Button>
                </ListGroup.Item>
    });

    return(
        <ListGroup as="ul" variant="flush" className="w-50 mx-auto">
            {todos}
        </ListGroup>
    );
};

export default ToDoList;