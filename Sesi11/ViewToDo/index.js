//initial data

// DOM elements
const todoForm = document.querySelector("#todo-form")
const todoList = document.querySelector("#todo-list")

// event Listeners
todoForm.addEventListener("submit", handleTodoFormSubmit)
//todoList.addEventListener("click", handleTodoListClick)

function handleTodoFormSubmit(event) {
    event.preventDefault()
    console.log(allTodos)

    const todoObj = {
        id: allTodos[allTodos.length - 1].id + 1,
        title: event.target.title.value,
        description: event.target.description.value,
        done: false
    }
    createTodo(todoObj)
    .then(newTodoObj => {
        renderOneTodo(newTodoObj)
        console.log('Success:', newTodoObj)
    })
    event.target.reset()
}

let allTodos = []

//initial render
function initialize() {
    getAllTodos()
    .then(todoArray => {
        allTodos = todoArray
        renderAllTodos(todoArray)
    })
    .catch(errors =>{
        alert("Something went wrong!")
    })
}

function renderAllTodos(todoData) {
    console.log(todoData)
    todoData.forEach(renderOneTodo)
}

function renderOneTodo(todoObj) {
    const card = document.createElement("li")
    card.className = "card"
    card.dataset.id = todoObj.id
    card.dataset.title = todoObj.title
    card.dataset.description = todoObj.description
    card.dataset.done = todoObj.done

    card.innerHTML = `
    <div class="image">
        <button class="button delete-button" data-action="delete">X</button>
    </div>
    <div class="content">
        <h4>${todoObj.title}</h4>
        <div class="donations">
            <span class="donations-count">${todoObj.done ? "Finish" : "Unfinished"}</span>
        </div>
        <p class="description">${todoObj.description}</p>
        ${!todoObj.done ?
            `<button class="button donate-button" data-action="update">
            Finish
            </button>`:''
        }
    </div>
    `
    todoList.append(card)
}

initialize()