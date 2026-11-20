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
type PointsResources =
    [<DefaultValue(false)>] val mutable RESOURCE : string
    [<DefaultValue(false)>] val mutable RESOURCE_2 : string
    [<DefaultValue(false)>] val mutable RESOURCE_3 : string
    [<DefaultValue(false)>] val mutable RESOURCE_4 : string
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : PointsResources
    static member SINGLETON with get() : PointsResources = (PointsResources.jclinit(); PointsResources.jcell_SINGLETON) and set (jvalue: PointsResources) = (PointsResources.jclinit(); PointsResources.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PointsResources.jclinitDone then
            PointsResources.jclinitDone <- true
            PointsResources.jclinitBody()
    static member private jclinitBody() : unit =
        PointsResources.jcell_SINGLETON <- (new PointsResources())
        ()
    member this.jfields_PointsResources() : unit =
        this.RESOURCE <- "points_drop_20_by_20.png"
        this.RESOURCE_2 <- "points_2_drop_20_by_20.png"
        this.RESOURCE_3 <- "points_3_drop_20_by_20.png"
        this.RESOURCE_4 <- "points_4_drop_20_by_20.png"
        ()
    
    new () as this =
        {  }
        then
            this.jfields_PointsResources()
    
    static member getInstance() : PointsResources =
        PointsResources.SINGLETON


