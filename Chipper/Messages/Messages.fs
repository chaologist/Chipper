namespace Chipper.Messages

type public IMessage = interface
    end

type public IEvent = interface
    inherit IMessage
    end

type public ICommand = interface
    inherit IMessage
    end
