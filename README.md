# fixeradmin
Sample table viewer

Edit the web config in the Fixer.Api project and set the following app settings:
rowCount : The number of rows to view at a time.
orderField : The field or pk to order by (e.g. id)
connectionString : The connectionstring of the database which houses the table(s).

Run the Api project.

Edit TablePage.html and set the apiPath variable at the top of the page to the path and port of the API

To view how the API works, use the sample html page in http://localhost:[port]/TablePage.html
