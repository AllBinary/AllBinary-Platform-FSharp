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
type LimitCommandsVisitor =
    inherit Visitor
    [<DefaultValue(false)>] val mutable isNotSmallDisplay : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LimitCommandsVisitor.jclinitDone then
            LimitCommandsVisitor.jclinitDone <- true
            LimitCommandsVisitor.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () as this =
        { inherit Visitor() }
        then
            this.jctor1()
    member this.jctor1() : unit =
        let mutable displayInfo : DisplayInfoSingleton = DisplayInfoSingleton.getInstance()
        this.isNotSmallDisplay <- (displayInfo.isPortrait() && (displayInfo.getLastHeight() > ScreenInfo.getInstance().SMALL_WIDTH)) || ((not (displayInfo.isPortrait())) && (displayInfo.getLastHeight() > ScreenInfo.getInstance().SMALL_HEIGHT))
        ()
    
    override this.visit(anyType: obj) : obj =
        let mutable jflow = 0
        let mutable jret : obj = Unchecked.defaultof<obj>
        let mutable command : Command = (box (anyType) :?> Command)
        let mutable booleanFactory : BooleanFactory = BooleanFactory.getInstance()
        if ((this.isNotSmallDisplay || (command.getPriority() = 1)) || ((JR.same(command, GameCommandsFactory.getInstance().EXIT_COMMAND)))) || ((JR.same(command, GameCommandsFactory.getInstance().EXIT_WITHOUT_PROGRESS_COMMAND))) then
            jret <- booleanFactory.TRUE
            jflow <- 1
        else
            jret <- booleanFactory.FALSE
            jflow <- 1
        jret


