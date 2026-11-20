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
type MainFeatureFactory =
    [<DefaultValue(false)>] val mutable FULL_SCREEN : Feature
    [<DefaultValue(false)>] val mutable TITLE_BAR : Feature
    [<DefaultValue(false)>] val mutable STATIC : Feature
    [<DefaultValue(false)>] val mutable LOAD_ONDEMAND : Feature
    [<DefaultValue(false)>] val mutable LOAD_ALL : Feature
    [<DefaultValue(false)>] static val mutable private jcell_instance : MainFeatureFactory
    static member instance with get() : MainFeatureFactory = (MainFeatureFactory.jclinit(); MainFeatureFactory.jcell_instance) and set (jvalue: MainFeatureFactory) = (MainFeatureFactory.jclinit(); MainFeatureFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MainFeatureFactory.jclinitDone then
            MainFeatureFactory.jclinitDone <- true
            MainFeatureFactory.jclinitBody()
    static member private jclinitBody() : unit =
        MainFeatureFactory.jcell_instance <- (new MainFeatureFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_MainFeatureFactory()
    member this.jfields_MainFeatureFactory() : unit =
        this.FULL_SCREEN <- (new Feature("Full Screen"))
        this.TITLE_BAR <- (new Feature("Title Bar"))
        this.STATIC <- (new Feature("Static Dependent Feature"))
        this.LOAD_ONDEMAND <- (new Feature("Load OnDemand"))
        this.LOAD_ALL <- (new Feature("Load All"))
        ()
    
    static member getInstance() : MainFeatureFactory =
        MainFeatureFactory.instance


