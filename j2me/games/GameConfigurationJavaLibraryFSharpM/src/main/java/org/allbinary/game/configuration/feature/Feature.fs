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
type Feature =
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] static val mutable private jcell_hashtable : ABHashtable
    static member hashtable with get() : ABHashtable = (Feature.jclinit(); Feature.jcell_hashtable) and set (jvalue: ABHashtable) = (Feature.jclinit(); Feature.jcell_hashtable <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Feature.jclinitDone then
            Feature.jclinitDone <- true
            Feature.jclinitBody()
    static member private jclinitBody() : unit =
        Feature.jcell_hashtable <- StdUtil.getInstance().createHashtable()
        ()
    
    new (name: string) as this =
        {  }
        then
            this.jctor1(name)
    member this.jctor1(name: string) : unit =
        this.name <- name
        Feature.add(name, this)
        ignore (ChangedGameFeatureListener.getInstance().add(this))
        ()
    
    static member getInstance(name: string) : Feature =
        (box (Feature.hashtable.get(name)) :?> Feature)
    
    static member add(name: string, gameFeature: Feature) : unit =
        ignore (Feature.hashtable.put(name, gameFeature))
    
    override this.ToString() : string =
        this.getName()
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name


