Project Name: CRUD Web API for building a list of freelancers

Description: This is a CRUD (Create, Read, Update, Delete) Web API built using ASP.NET Core for building a list of freelancers.

Operations:

a) Create a new person record.
b) View a list of person records.
c) Update an existing person record.
d) Delete an existing person record.

Endpoints:

a) GET /api/PersonDt: Get a list of all person details.
b) POST /api/PersonDt: Create a new person detail record.
c) PUT /api/PersonDt/{id}: Update an existing person detail record by ID.
d) DELETE /api/PersonDt/{id}: Delete an existing person detail record by ID

Usage:

a) Create a New Person Record:
-Send a POST request to http://localhost:5000/api/PersonDt with a JSON body containing the person details.
b) Update an Existing Person Record:
-Send a PUT request to http://localhost:5000/api/PersonDt/{id} with a JSON body containing the updated person details.
c) Delete an Existing Person Record:
-Send a DELETE request to http://localhost:5000/api/PersonDt/{id} to delete a person record by ID.
d) Getting a List of All Person Records:
-Send a GET request to http://localhost:5000/api/PersonDt to retrieve a list of all person records.


![image](https://github.com/KishenPrekash/WebAPIApp/assets/95667797/a3169bf4-2bce-483b-a13e-e152dab8dae8)
