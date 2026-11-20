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
type InGameFeatureChoiceGroups =
    [<DefaultValue(false)>] val mutable hashtable : ABHashtable
    [<DefaultValue(false)>] static val mutable private jcell_gameFeatureChoiceGroupsExclusive : InGameFeatureChoiceGroups
    static member gameFeatureChoiceGroupsExclusive with get() : InGameFeatureChoiceGroups = (InGameFeatureChoiceGroups.jclinit(); InGameFeatureChoiceGroups.jcell_gameFeatureChoiceGroupsExclusive) and set (jvalue: InGameFeatureChoiceGroups) = (InGameFeatureChoiceGroups.jclinit(); InGameFeatureChoiceGroups.jcell_gameFeatureChoiceGroupsExclusive <- jvalue)
    [<DefaultValue(false)>] static val mutable private jcell_gameFeatureChoiceGroupsMultiple : InGameFeatureChoiceGroups
    static member gameFeatureChoiceGroupsMultiple with get() : InGameFeatureChoiceGroups = (InGameFeatureChoiceGroups.jclinit(); InGameFeatureChoiceGroups.jcell_gameFeatureChoiceGroupsMultiple) and set (jvalue: InGameFeatureChoiceGroups) = (InGameFeatureChoiceGroups.jclinit(); InGameFeatureChoiceGroups.jcell_gameFeatureChoiceGroupsMultiple <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InGameFeatureChoiceGroups.jclinitDone then
            InGameFeatureChoiceGroups.jclinitDone <- true
            InGameFeatureChoiceGroups.jclinitBody()
    static member private jclinitBody() : unit =
        InGameFeatureChoiceGroups.jcell_gameFeatureChoiceGroupsExclusive <- (new InGameFeatureChoiceGroups())
        InGameFeatureChoiceGroups.jcell_gameFeatureChoiceGroupsMultiple <- (new InGameFeatureChoiceGroups())
        ()
    member this.jfields_InGameFeatureChoiceGroups() : unit =
        this.hashtable <- StdUtil.getInstance().createHashtable()
        ()
    
    new () as this =
        {  }
        then
            this.jfields_InGameFeatureChoiceGroups()
    
    static member getExclusiveInstance() : InGameFeatureChoiceGroups =
        InGameFeatureChoiceGroups.gameFeatureChoiceGroupsExclusive
    
    static member getMultipleInstance() : InGameFeatureChoiceGroups =
        InGameFeatureChoiceGroups.gameFeatureChoiceGroupsMultiple
    
    abstract get : unit -> ABHashtable
    default this.get() : ABHashtable =
        this.hashtable
    
    abstract add : name: string * list_: BasicArrayList -> unit
    default this.add(name: string, list_: BasicArrayList) : unit =
        ignore (this.hashtable.put(name, list_))


