# Project Title

Birthday Problem Code Exercise

## Description

Simple programm that reads csv input that contains a list of persons name and birthday. The program checks if a person in the list has it's birthday today and if true it prints to the console happy birthday.

## Getting Started

### Dependencies

* .NET 8.0
* Make

### Installing

* Clone repo and run `make build` to build project and run tests
* Run `make run` to run the program

### Executing program

1. Build and run tests
   ```sh
   make build
   ```
2. Run locally
   ```sh
   make run
   ```

## Extend the program

### Leap year day

Currently the program does not consider if a person birthday is on the 29th of February and year is not leap year.

`Given` a person has a birthday on 29th of February

`When` today is 28th of February

`And` year is not leap year

`Then` that person should receive a Happy Birthday greeting

### Json input

Currently the program does not support reading Json input but there is a `person.json` file in the project.

Add a new adapter that supports reading a Json file as input.