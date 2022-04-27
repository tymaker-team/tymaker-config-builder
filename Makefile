all : clean restore build publish

clean:
	dotnet clean

restore:
	dotnet restore

build: 
	dotnet build

publish:
	dotnet publish --output "publish" --runtime linux-x64 --configuration Release -p:PublishSingleFile=true --self-contained true

run:
	dotnet run
  
install:
	cp publish/tymaker /usr/bin/tymaker
	echo If an error is thrown, make sure you have ran 'dotnet publish' first.

uninstall:
	rm /usr/bin/tymaker
