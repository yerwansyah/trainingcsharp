function getAllTodos() {
    return fetch("http://localhost:5267/api/Todo")
        .then(response => response.json())
}