#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p 2304f8c2-2f39-49ca-9c77-b201f0c1044c -t
    fi
    cd ../
fi

docker-compose up -d
