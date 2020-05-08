# columba-challange

The project is compatible with dotnet core 2.2

# Execute the test outside of VS with help of docker

From the root project

Go to 
cd ColumbaChallange.MathLib

then build the test container
docker build -t a .

now run the test container
docker run -it a