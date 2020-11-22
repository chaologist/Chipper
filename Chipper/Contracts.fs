namespace Chipper

open Chipper.Messages

type public IEventPublisher = interface
    abstract member PublishAsync: IEvent->System.Threading.Tasks.Task
end

type public ICommandSender = interface
    abstract member SendAsync: ICommand->System.Threading.Tasks.Task
end

type public IMessagingContext = interface
    inherit IEventPublisher
    inherit ICommandSender
end

type public IHandleEvent<'TEvent when 'TEvent :> IEvent> = interface
    abstract member HandleEventAsync: 'TEvent->IMessagingContext->System.Threading.Tasks.Task
end

type public IExecuteCommand<'TCommand when 'TCommand :> ICommand> = interface
    abstract member ExecuteCommandAsync: 'TCommand->IMessagingContext->System.Threading.Tasks.Task
end