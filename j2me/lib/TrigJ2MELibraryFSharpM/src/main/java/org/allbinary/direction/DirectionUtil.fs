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
type DirectionUtil =
    [<DefaultValue(false)>] val mutable directionArray : Angle[]
    [<DefaultValue(false)>] val mutable directionArray2 : Angle[]
    [<DefaultValue(false)>] static val mutable private jcell_instance : DirectionUtil
    static member instance with get() : DirectionUtil = (DirectionUtil.jclinit(); DirectionUtil.jcell_instance) and set (jvalue: DirectionUtil) = (DirectionUtil.jclinit(); DirectionUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DirectionUtil.jclinitDone then
            DirectionUtil.jclinitDone <- true
            DirectionUtil.jclinitBody()
    static member private jclinitBody() : unit =
        DirectionUtil.jcell_instance <- (new DirectionUtil())
        ()
    member this.jfields_DirectionUtil() : unit =
        this.directionArray <- (Array.zeroCreate<Angle> (10))
        this.directionArray2 <- (Array.zeroCreate<Angle> (10))
        ()
    
    static member getInstance() : DirectionUtil =
        DirectionUtil.instance
    
    new () as this =
        {  }
        then
            this.jfields_DirectionUtil()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable angleFactory : AngleFactory = AngleFactory.getInstance()
        let mutable directionFactory : DirectionFactory = DirectionFactory.getInstance()
        this.directionArray.[directionFactory.LEFT.getValue()] <- angleFactory.LEFT
        this.directionArray.[directionFactory.RIGHT.getValue()] <- angleFactory.RIGHT
        this.directionArray.[directionFactory.UP.getValue()] <- angleFactory.UP
        this.directionArray.[directionFactory.DOWN.getValue()] <- angleFactory.DOWN
        this.directionArray2.[directionFactory.LEFT.getValue()] <- angleFactory.LEFT
        this.directionArray2.[directionFactory.RIGHT.getValue()] <- angleFactory.RIGHT
        this.directionArray2.[directionFactory.UP.getValue()] <- angleFactory.UP
        this.directionArray2.[directionFactory.DOWN.getValue()] <- angleFactory.DOWN
        ()
    
    abstract getAngle : direction: Direction -> Angle
    default this.getAngle(direction: Direction) : Angle =
        this.directionArray2.[direction.getValue()]
    
    abstract getFrameAngle : direction: Direction -> Angle
    default this.getFrameAngle(direction: Direction) : Angle =
        this.directionArray.[direction.getValue()]


