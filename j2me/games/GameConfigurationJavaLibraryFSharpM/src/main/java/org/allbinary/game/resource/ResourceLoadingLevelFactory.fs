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
type ResourceLoadingLevelFactory =
    [<DefaultValue(false)>] val mutable LOAD_EARLY : ResourceLoadingLevel
    [<DefaultValue(false)>] val mutable LOAD_TOUCH : ResourceLoadingLevel
    [<DefaultValue(false)>] val mutable LOAD_GAME : ResourceLoadingLevel
    [<DefaultValue(false)>] val mutable LEVEL : ResourceLoadingLevel
    [<DefaultValue(false)>] val mutable MAX_LEVEL : ResourceLoadingLevel
    [<DefaultValue(false)>] val mutable LOAD_ALL : ResourceLoadingLevel
    [<DefaultValue(false)>] val mutable RESOURCE_LOADING_LEVEL_ARRAY : ResourceLoadingLevel[]
    [<DefaultValue(false)>] static val mutable private jcell_instance : ResourceLoadingLevelFactory
    static member instance with get() : ResourceLoadingLevelFactory = (ResourceLoadingLevelFactory.jclinit(); ResourceLoadingLevelFactory.jcell_instance) and set (jvalue: ResourceLoadingLevelFactory) = (ResourceLoadingLevelFactory.jclinit(); ResourceLoadingLevelFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ResourceLoadingLevelFactory.jclinitDone then
            ResourceLoadingLevelFactory.jclinitDone <- true
            ResourceLoadingLevelFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ResourceLoadingLevelFactory.jcell_instance <- (new ResourceLoadingLevelFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_ResourceLoadingLevelFactory()
    member this.jfields_ResourceLoadingLevelFactory() : unit =
        this.LOAD_EARLY <- (new ResourceLoadingLevel("Load Early", Integer.MAX_VALUE))
        this.LOAD_TOUCH <- (new ResourceLoadingLevel("Load Touch", (Integer.MAX_VALUE - 1)))
        this.LOAD_GAME <- (new ResourceLoadingLevel("Load Game", (Integer.MAX_VALUE - 2)))
        this.LEVEL <- (new ResourceLoadingLevel("Level", (Integer.MAX_VALUE - 99)))
        this.MAX_LEVEL <- (new ResourceLoadingLevel("Max Level", (Integer.MAX_VALUE - 100)))
        this.LOAD_ALL <- (new ResourceLoadingLevel("Load All", -1))
        this.RESOURCE_LOADING_LEVEL_ARRAY <- ([| this.LOAD_ALL; this.MAX_LEVEL; this.LEVEL; this.LOAD_GAME; this.LOAD_TOUCH; this.LOAD_EARLY |] : ResourceLoadingLevel[])
        ()
    
    static member getInstance() : ResourceLoadingLevelFactory =
        ResourceLoadingLevelFactory.instance
    
    abstract getLevelString : level: int -> string
    default this.getLevelString(level: int) : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        let mutable index : int = 0
        while jflow = 0 && (index < this.RESOURCE_LOADING_LEVEL_ARRAY.Length) do
            if level = this.RESOURCE_LOADING_LEVEL_ARRAY.[index].getLevel() then
                jret <- this.RESOURCE_LOADING_LEVEL_ARRAY.[index].getName()
                jflow <- 1
            if jflow = 200001 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            jret <- Integer.toString(level)
            jflow <- 1
        jret


