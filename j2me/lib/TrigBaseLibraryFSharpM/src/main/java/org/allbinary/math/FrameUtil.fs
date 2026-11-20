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
type FrameUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : FrameUtil
    static member instance with get() : FrameUtil = (FrameUtil.jclinit(); FrameUtil.jcell_instance) and set (jvalue: FrameUtil) = (FrameUtil.jclinit(); FrameUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FrameUtil.jclinitDone then
            FrameUtil.jclinitDone <- true
            FrameUtil.jclinitBody()
    static member private jclinitBody() : unit =
        FrameUtil.jcell_instance <- (new FrameUtil())
        ()
    
    static member getInstance() : FrameUtil =
        FrameUtil.instance
    
    new () =
        {  }
    
    abstract getFrameForAngle : angle: int16 * angleIncrement: int -> int
    default this.getFrameForAngle(angle: int16, angleIncrement: int) : int =
        this.adjustAngleToFrameAngle(int (angle)) / angleIncrement
    
    abstract getFrameAngle : frame: int * angleIncrement: int -> int
    default this.getFrameAngle(frame: int, angleIncrement: int) : int =
        let mutable frameAngle : int = (angleIncrement * frame) - 90
        this.adjustAngleToFrameAngle(frameAngle)
    
    abstract adjustAngleToFrameAngle : currentAngle: int -> int
    default this.adjustAngleToFrameAngle(currentAngle: int) : int =
        let mutable currentAngle = currentAngle
        let mutable angleFactory : AngleFactory = AngleFactory.getInstance()
        if currentAngle > 359 then
            currentAngle <- (currentAngle - int (int (angleFactory.TOTAL_ANGLE)))
            while currentAngle > 359 do
                currentAngle <- (currentAngle - int (int (angleFactory.TOTAL_ANGLE)))
        if currentAngle < 0 then
            currentAngle <- (currentAngle + int (int (angleFactory.TOTAL_ANGLE)))
            while currentAngle < 0 do
                currentAngle <- (currentAngle + int (int (angleFactory.TOTAL_ANGLE)))
        currentAngle


