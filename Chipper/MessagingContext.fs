namespace Chipper

open Chipper.Messages

type public MessagingContext () =
    interface IMessagingContext with
        member this. PublishAsync(event: IEvent) =
            System.Threading.Tasks.Task.CompletedTask  
        member this. SendAsync(event: ICommand) =  
            System.Threading.Tasks.Task.CompletedTask               