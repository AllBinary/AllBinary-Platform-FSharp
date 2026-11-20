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
type AngleIncrementInfoFactory =
    [<DefaultValue(false)>] val mutable angleIncrementInfo : AngleIncrementInfo[]
    [<DefaultValue(false)>] static val mutable private jcell_instance : AngleIncrementInfoFactory
    static member instance with get() : AngleIncrementInfoFactory = (AngleIncrementInfoFactory.jclinit(); AngleIncrementInfoFactory.jcell_instance) and set (jvalue: AngleIncrementInfoFactory) = (AngleIncrementInfoFactory.jclinit(); AngleIncrementInfoFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AngleIncrementInfoFactory.jclinitDone then
            AngleIncrementInfoFactory.jclinitDone <- true
            AngleIncrementInfoFactory.jclinitBody()
    static member private jclinitBody() : unit =
        AngleIncrementInfoFactory.jcell_instance <- (new AngleIncrementInfoFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_AngleIncrementInfoFactory()
    member this.jfields_AngleIncrementInfoFactory() : unit =
        this.angleIncrementInfo <- (Array.zeroCreate<AngleIncrementInfo> (int (AngleFactory.getInstance().TOTAL_ANGLE)))
        ()
    
    static member getInstance() : AngleIncrementInfoFactory =
        AngleIncrementInfoFactory.instance
    
    abstract getAt : angleIncrement: int16 -> AngleIncrementInfo
    default this.getAt(angleIncrement: int16) : AngleIncrementInfo =
        let mutable jflow = 0
        let mutable jret : AngleIncrementInfo = Unchecked.defaultof<AngleIncrementInfo>
        let mutable halfAngleIncrement : int = (int (angleIncrement) >>> 1)
        let mutable angleIncrementInfo : AngleIncrementInfo = null
        let mutable angleIncrementInfoCanBeNull : AngleIncrementInfo = this.angleIncrementInfo.[halfAngleIncrement]
        if (JR.same(angleIncrementInfoCanBeNull, null)) then
            angleIncrementInfo <- (new AngleIncrementInfo(angleIncrement))
            this.angleIncrementInfo.[halfAngleIncrement] <- angleIncrementInfo
            jret <- angleIncrementInfo
            jflow <- 1
        else
            angleIncrementInfo <- angleIncrementInfoCanBeNull
        if jflow = 0 then
            jret <- angleIncrementInfo
            jflow <- 1
        jret


