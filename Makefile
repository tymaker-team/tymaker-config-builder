all : clean restore build publish

clean:
	dotnet clean

restore:
	dotnet restore

build: 
	dotnet build

publish:
	ifeq ($(OS),Windows_NT)
		dotnet publish --output "publish" --runtime win-x64 --configuration Release -p:PublishSingleFile=true --self-contained true
	else
		UNAME_S := $(shell uname -s)
		ifeq ($(UNAME_S),Linux)
			dotnet publish --output "publish" --runtime linux-x64 --configuration Release -p:PublishSingleFile=true --self-contained true
		else
			ifeq ($(UNAME_S),Darwin)
			dotnet publish --output "publish" --runtime osx-x64 --configuration Release -p:PublishSingleFile=true --self-contained true
			endif
		endif
	endif
run:
	dotnet run
  
install:
	cp publish/tymaker /usr/bin/tymaker
	echo If an error is thrown, make sure you have ran 'dotnet publish' first.

uninstall:
	rm /usr/bin/tymaker
