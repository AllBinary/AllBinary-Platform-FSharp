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
type AngleIncrementInfo =
    [<DefaultValue(false)>] val mutable angleIncrement : int16
    [<DefaultValue(false)>] val mutable DOWN_FRAME : Integer
    [<DefaultValue(false)>] val mutable UP_FRAME : Integer
    [<DefaultValue(false)>] val mutable LEFT_FRAME : Integer
    [<DefaultValue(false)>] val mutable RIGHT_FRAME : Integer
    [<DefaultValue(false)>] val mutable frameUtil : FrameUtil
    static member INCREMENT : string = "Inc: "
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AngleIncrementInfo.jclinitDone then
            AngleIncrementInfo.jclinitDone <- true
            AngleIncrementInfo.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_AngleIncrementInfo() : unit =
        this.frameUtil <- FrameUtil.getInstance()
        ()
    
    new (angleIncrement: int16) as this =
        {  }
        then
            this.jfields_AngleIncrementInfo()
            this.jctor1(angleIncrement)
    member this.jctor1(angleIncrement: int16) : unit =
        this.angleIncrement <- angleIncrement
        let mutable angleFactory : AngleFactory = AngleFactory.getInstance()
        let mutable smallIntegerSingletonFactory : SmallIntegerSingletonFactory = SmallIntegerSingletonFactory.getInstance()
        this.DOWN_FRAME <- smallIntegerSingletonFactory.getAt((int (angleFactory.DOWN.getValue()) / int (this.angleIncrement)))
        this.UP_FRAME <- smallIntegerSingletonFactory.getAt(int (angleFactory.UP.getValue()))
        this.LEFT_FRAME <- smallIntegerSingletonFactory.getAt((int (angleFactory.LEFT.getValue()) / int (this.angleIncrement)))
        this.RIGHT_FRAME <- smallIntegerSingletonFactory.getAt((int (angleFactory.RIGHT.getValue()) / int (this.angleIncrement)))
        ()
    
    abstract getFrameAngle : frame: int -> int
    default this.getFrameAngle(frame: int) : int =
        this.frameUtil.getFrameAngle(frame, int (this.angleIncrement))
    
    abstract getAngleIncrement : unit -> int16
    default this.getAngleIncrement() : int16 =
        this.angleIncrement
    
    override this.ToString() : string =
        (new StringMaker()).append(AngleIncrementInfo.INCREMENT).appendshort(this.angleIncrement).ToString()
    
    abstract getClosestGeneralDirection : angle: int16 -> int
    default this.getClosestGeneralDirection(angle: int16) : int =
        let mutable closestDirection : Integer = SmallIntegerSingletonFactory.getInstance().getAt(360)
        if (this.UP_FRAME.intValue() - int (int (angle))) < (closestDirection.intValue() - int (int (angle))) then
            closestDirection <- this.UP_FRAME
        if (this.DOWN_FRAME.intValue() - int (int (angle))) < (closestDirection.intValue() - int (int (angle))) then
            closestDirection <- this.DOWN_FRAME
        if (this.LEFT_FRAME.intValue() - int (int (angle))) < (closestDirection.intValue() - int (int (angle))) then
            closestDirection <- this.LEFT_FRAME
        if (this.RIGHT_FRAME.intValue() - int (int (angle))) < (closestDirection.intValue() - int (int (angle))) then
            closestDirection <- this.RIGHT_FRAME
        closestDirection.intValue()


