namespace FSRejectLib

open System

module Reject =
    let rejectBlacklisted (str: string) =
        String.filter (fun x -> List.contains x ['a'; 'e'; 'i'; 'o'; 'u'; ' '] |> not) str

