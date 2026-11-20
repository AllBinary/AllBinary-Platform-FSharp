namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2011 AllBinary
 * 
 * By agreeing to this license you and any business entity you represent are
 * legally bound to the AllBinary Open License Version 1 legal agreement.
 * 
 * You may obtain the AllBinary Open License Version 1 legal agreement from
 * AllBinary or the root directory of AllBinary's AllBinary Platform repository.
 * 
 * Created By: Travis Berthelot
 *  
 *)

[<AllowNullLiteral>]
type CommandTextItem =
    inherit ABTextItem
    [<DefaultValue(false)>] val mutable command : Command
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CommandTextItem.jclinitDone then
            CommandTextItem.jclinitDone <- true
            CommandTextItem.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (command: Command, layout: int, altText: string, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit ABTextItem(command.getLabel(), layout, altText, backgroundBasicColor, foregroundBasicColor) }
        then
            this.jctor1(command, layout, altText, backgroundBasicColor, foregroundBasicColor)
    member this.jctor1(command: Command, layout: int, altText: string, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        this.command <- command
        ()
    
    override this.isFocusable() : bool =
        true
    
    abstract getCommand : unit -> Command
    default this.getCommand() : Command =
        this.command


