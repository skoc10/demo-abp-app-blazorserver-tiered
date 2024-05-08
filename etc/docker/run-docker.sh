#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p f0442807-3ebc-4e31-a839-e3a32a483f17 -t
    fi
    cd ../
fi

docker-compose up -d
