module TstsServer
open Fable.Core
open Fable.Meteor
open MyCollections

let count = todos.find().count()
if count = 0.0 then
     printfn "zero!"
     for x in 1..10 do
            let todo = {
                Todos.Title = "title"
                Todos.Done = false
            } 
            let id = todos.insert todo
            printfn "%A" id
else
    printfn "exist"
    for x in todos.find().fetch() do
        printfn "%A" x
        