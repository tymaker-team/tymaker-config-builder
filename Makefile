all : clean restore publish

clean:
	dotnet clean

restore:
	dotnet restore

build: 
	dotnet build

publish:
ifeq ($(OS),Windows_NT)
	dotnet publish --output "publish" --runtime win-x64 --configuration Release -p:PublishSingleFile=true --self-contained true
endif
ifeq ($(shell uname -s),Linux)
	dotnet publish --output "publish" --runtime linux-x64 --configuration Release -p:PublishSingleFile=true --self-contained true
endif
ifeq ($(shell uname -s),Darwin)
	dotnet publish --output "publish" --runtime osx-x64 --configuration Release -p:PublishSingleFile=true --self-contained true
endif
run:
	dotnet run
