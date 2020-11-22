namespace Chipper
open System.Collections.Generic

type public HandlerRegister() = class
    
    let l = new List<System.Type>()

    member this.RegisterEventHandler<'T, 'TE when 'T :>IHandleEvent<'TE> >() =
        l.Add (typeof<'T>)
    member this.RegisterCommandExecutor<'T, 'TC when 'T :>IExecuteCommand<'TC> >() =
        l.Add (typeof<'T>)

    member this.RegisteredTypes with get () = l
    end

type public Endpoint private(messagingContext: IMessagingContext) = class
    member val MessagingContext = messagingContext
    static member Endpoint (handlerRegister: HandlerRegister) =
        new Endpoint(new MessagingContext())
    member this.ConnectAsync () =
        System.Threading.Tasks.Task.CompletedTask
    end