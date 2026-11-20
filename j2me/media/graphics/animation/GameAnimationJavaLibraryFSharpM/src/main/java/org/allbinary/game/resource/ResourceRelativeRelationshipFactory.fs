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
type ResourceRelativeRelationshipFactory =
    [<DefaultValue(false)>] val mutable basicArrayListUtil : BasicArrayListUtil
    [<DefaultValue(false)>] val mutable hashtable : ABHashtable
    [<DefaultValue(false)>] val mutable initialized : bool
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ResourceRelativeRelationshipFactory.jclinitDone then
            ResourceRelativeRelationshipFactory.jclinitDone <- true
            ResourceRelativeRelationshipFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_ResourceRelativeRelationshipFactory()
    member this.jfields_ResourceRelativeRelationshipFactory() : unit =
        this.basicArrayListUtil <- BasicArrayListUtil.getInstance()
        this.hashtable <- StdUtil.getInstance().createHashtable()
        ()
    
    abstract init : level: int -> unit
    default this.init(level: int) : unit =
        this.setInitialized(true)
    
    abstract getResourceRelativeRelationshipList : resource: string -> BasicArrayList
    default this.getResourceRelativeRelationshipList(resource: string) : BasicArrayList =
        let mutable jflow = 0
        let mutable jret : BasicArrayList = Unchecked.defaultof<BasicArrayList>
        let mutable listCanBeNull : obj = this.hashtable.get(resource)
        if (JR.same(listCanBeNull, null)) then
            jret <- this.basicArrayListUtil.getImmutableInstance()
            jflow <- 1
        if jflow = 0 then
            jret <- (box (listCanBeNull) :?> BasicArrayList)
            jflow <- 1
        jret
    
    abstract addResourceRelativeRelationship : resource: string * hardPoint: RelativeRelationship -> unit
    default this.addResourceRelativeRelationship(resource: string, hardPoint: RelativeRelationship) : unit =
        let mutable list_ : BasicArrayList = this.getResourceRelativeRelationshipList(resource)
        if (JR.same(list_, this.basicArrayListUtil.getImmutableInstance())) then
            list_ <- (new BasicArrayListD())
        ignore (list_.add(hardPoint))
        ignore (this.hashtable.put(resource, list_))
    
    abstract isLoadingLevel : level: int -> bool
    default this.isLoadingLevel(level: int) : bool =
        false
    
    abstract isFeature : unit -> bool
    default this.isFeature() : bool =
        false
    
    abstract setInitialized : initialized: bool -> unit
    default this.setInitialized(initialized: bool) : unit =
        this.initialized <- initialized
    
    abstract isInitialized : unit -> bool
    default this.isInitialized() : bool =
        this.initialized
    interface ResourceRelativeRelationshipFactoryInterface with
        member this.getResourceRelativeRelationshipList(jp0: string) : BasicArrayList = this.getResourceRelativeRelationshipList(jp0)
        member this.addResourceRelativeRelationship(jp0: string, jp1: RelativeRelationship) : unit = this.addResourceRelativeRelationship(jp0, jp1)
    interface GameFeatureControlledInterface with
        member this.init(jp0: int) : unit = this.init(jp0)
        member this.isFeature() : bool = this.isFeature()
        member this.isLoadingLevel(jp0: int) : bool = this.isLoadingLevel(jp0)


