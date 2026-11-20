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
type MotionGestureConfiguration =
    [<DefaultValue(false)>] val mutable diagonalMotionGestureAllowed : bool
    [<DefaultValue(false)>] val mutable diagonalTolerance : int
    [<DefaultValue(false)>] val mutable minimumMotionGesture : int
    [<DefaultValue(false)>] val mutable button : string
    [<DefaultValue(false)>] val mutable color : BasicColor
    [<DefaultValue(false)>] val mutable executingActions : bool
    [<DefaultValue(false)>] val mutable mouseButtonMask : int
    [<DefaultValue(false)>] val mutable activeCommands : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MotionGestureConfiguration.jclinitDone then
            MotionGestureConfiguration.jclinitDone <- true
            MotionGestureConfiguration.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_MotionGestureConfiguration() : unit =
        this.diagonalMotionGestureAllowed <- true
        this.diagonalTolerance <- 7
        this.minimumMotionGesture <- 9
        this.button <- StringUtil.getInstance().EMPTY_STRING
        this.color <- BasicColorFactory.getInstance().BLUE
        this.executingActions <- true
        this.mouseButtonMask <- 0
        this.activeCommands <- (new BasicArrayListD())
        ()
    
    new () as this =
        {  }
        then
            this.jfields_MotionGestureConfiguration()
    
    abstract addMotionGestureAction : list_: BasicArrayList * commandAction: CompleteMotionGestureInputEvent -> unit
    default this.addMotionGestureAction(list_: BasicArrayList, commandAction: CompleteMotionGestureInputEvent) : unit =
        ignore (this.activeCommands.add((new MotionGestureToMotionGestureActionAssociation(list_, commandAction))))
    
    abstract clearMotionGestureAction : unit -> unit
    default this.clearMotionGestureAction() : unit =
        this.activeCommands.clear()
    
    abstract getAssociateCommandActionsList : unit -> BasicArrayList
    default this.getAssociateCommandActionsList() : BasicArrayList =
        this.activeCommands
    
    abstract isDiagonalMotionGestureAllowed : unit -> bool
    default this.isDiagonalMotionGestureAllowed() : bool =
        this.diagonalMotionGestureAllowed
    
    abstract isExecutingActionsAllowed : unit -> bool
    default this.isExecutingActionsAllowed() : bool =
        this.executingActions
    
    abstract setExecutingActionsAllowed : executingActionAllowed: bool -> unit
    default this.setExecutingActionsAllowed(executingActionAllowed: bool) : unit =
        this.executingActions <- executingActionAllowed
    
    abstract setDiagonalMotionGestureAllowed : diagonalMotionGestureAllowed: bool -> unit
    default this.setDiagonalMotionGestureAllowed(diagonalMotionGestureAllowed: bool) : unit =
        this.diagonalMotionGestureAllowed <- diagonalMotionGestureAllowed
    
    abstract getDiagonalTolerance : unit -> int
    default this.getDiagonalTolerance() : int =
        this.diagonalTolerance
    
    abstract setDiagonalTolerance : diagonalTolerance: int -> unit
    default this.setDiagonalTolerance(diagonalTolerance: int) : unit =
        this.diagonalTolerance <- diagonalTolerance
    
    abstract getMinimumMotionGesture : unit -> int
    default this.getMinimumMotionGesture() : int =
        this.minimumMotionGesture
    
    abstract setMinimumMotionGesture : minimumMotionGesture: int -> unit
    default this.setMinimumMotionGesture(minimumMotionGesture: int) : unit =
        this.minimumMotionGesture <- minimumMotionGesture
    
    abstract getButton : unit -> string
    default this.getButton() : string =
        this.button
    
    abstract setButton : button: string -> unit
    default this.setButton(button: string) : unit =
        this.button <- button
    
    abstract getColor : unit -> BasicColor
    default this.getColor() : BasicColor =
        this.color
    
    abstract setColor : color: BasicColor -> unit
    default this.setColor(color: BasicColor) : unit =
        this.color <- color
    
    abstract getMouseButtonMask : unit -> int
    default this.getMouseButtonMask() : int =
        this.mouseButtonMask
    
    abstract setMouseButtonMask : mouseButtonMask: int -> unit
    default this.setMouseButtonMask(mouseButtonMask: int) : unit =
        this.mouseButtonMask <- mouseButtonMask


