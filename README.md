# AWS Lambda Empty Function Project

dotnet tool install -g Amazon.Lambda.Tools
dotnet tool install --global Amazon.Lambda.TestTool-6.0


dotnet new list --author AWS    





dotnet new  lambda.EmptyFunction --name BlogFunction --profile default --region sa-east-1


## test local

dotnet build 

dotnet lambda-test-tool-6.0