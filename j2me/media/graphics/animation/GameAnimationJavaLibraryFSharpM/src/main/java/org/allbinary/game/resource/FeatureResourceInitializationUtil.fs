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
type FeatureResourceInitializationUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : FeatureResourceInitializationUtil
    static member instance with get() : FeatureResourceInitializationUtil = (FeatureResourceInitializationUtil.jclinit(); FeatureResourceInitializationUtil.jcell_instance) and set (jvalue: FeatureResourceInitializationUtil) = (FeatureResourceInitializationUtil.jclinit(); FeatureResourceInitializationUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FeatureResourceInitializationUtil.jclinitDone then
            FeatureResourceInitializationUtil.jclinitDone <- true
            FeatureResourceInitializationUtil.jclinitBody()
    static member private jclinitBody() : unit =
        FeatureResourceInitializationUtil.jcell_instance <- (new FeatureResourceInitializationUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_FeatureResourceInitializationUtil()
    member this.jfields_FeatureResourceInitializationUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    static member getInstance() : FeatureResourceInitializationUtil =
        FeatureResourceInitializationUtil.instance
    
    abstract init : level: int -> unit
    default this.init(level: int) : unit =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        this.logUtil.putF(commonStrings.START, this, commonStrings.INIT)
        let mutable featuredResourceFactory : FeaturedResourceFactory = FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance()
        featuredResourceFactory.init(level)
        FeaturedResourceRelativeRelationshipFactory.getInstance().init(level)


