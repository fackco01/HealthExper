fetch("https://localhost:7158/api/Account")
    .then(response => response.json())
    .then(data => console.log(data))
    .catch(error => console.error(error));