Approach followed up here is .Net Web api using a repository pattern
Created a interface for the web application and required models 
API's developed are basically like Crud operations 
Model for Task Creation and retrival of data
TaskItem
- Id (int)
- Title (string)
- Description (string)
- Status (Pending, InProgress, Completed)
- Priority (Low, Medium, High)
- CreatedAt (DateTime)

Create Task - API

In this API adding the user input task details to the List 
Id are incremented automatically
Response for the API is in the form of TaskItem Model.


