<h1>Task Manager CSharp</h1>

<p>RESTful API for task manager using layered architecture and single responsibility principle of S.O.L.I.D.</p>

<h2>Features</h2>

* Create, list, edit, and delete tasks.
* List all tasks.

<h2>Requirements</h2>

* .NET 8

<h2>Endpoints</h2>

| Route | Method | Description |
|---|---|---|
| `/api/tasks` | POST | Create new book |
| `/api/tasks` | GET | Get all books |
| `/api/tasks/{id}` | GET | Get book by ID |
| `/api/tasks/{id}` | PUT | Edit book by ID |
| `/api/tasks/{id}` | DELETE | Delete book by ID |

<h2>Status Codes</h2>

* 201: Created
* 200: OK
* 404: Not found
* 400: Validation error
* 500: Internal error
<h2>Usage Example</h2>

```html
curl -X POST \
  -H "Content-Type: application/json" \
  -d '{
    "name": "Test",
    "decription": "Hi",
    "priority": "High",
    "limited": "2024-04-26T02:14:29.731Z"
    "Status": Completed,
    "quantity": 10
  }' \
  http://localhost:5000/api/books

curl -X GET \
  http://localhost:5000/api/books
