Approach followed up here is .Net Web api using a repository pattern
Created a interface, controller,service for the web application and required models 
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

Get All Tasks - API

This API retrives all task and have a optional filter of  status and  priority
used Linq to filter out from the List
Response of the API is based  on taskitem Model

Get Task By Id - API

This APi returns the response based on User i/p Id
If task is not present in list it gives 404 not found
Response of the API is based  on taskitem Model

Update Task Status - API

this API is to update the status of the task
Pending → InProgress → Completed , transistions are allowed and validations are implemented
Response of the API is string format message which show up the status.

