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
type ArtificialIntelligenceInterfaceFactoryInterfaceFactory =
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : ArtificialIntelligenceInterfaceFactoryInterfaceFactory
    static member SINGLETON with get() : ArtificialIntelligenceInterfaceFactoryInterfaceFactory = (ArtificialIntelligenceInterfaceFactoryInterfaceFactory.jclinit(); ArtificialIntelligenceInterfaceFactoryInterfaceFactory.jcell_SINGLETON) and set (jvalue: ArtificialIntelligenceInterfaceFactoryInterfaceFactory) = (ArtificialIntelligenceInterfaceFactoryInterfaceFactory.jclinit(); ArtificialIntelligenceInterfaceFactoryInterfaceFactory.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ArtificialIntelligenceInterfaceFactoryInterfaceFactory.jclinitDone then
            ArtificialIntelligenceInterfaceFactoryInterfaceFactory.jclinitDone <- true
            ArtificialIntelligenceInterfaceFactoryInterfaceFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ArtificialIntelligenceInterfaceFactoryInterfaceFactory.jcell_SINGLETON <- (new ArtificialIntelligenceInterfaceFactoryInterfaceFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_ArtificialIntelligenceInterfaceFactoryInterfaceFactory()
    member this.jfields_ArtificialIntelligenceInterfaceFactoryInterfaceFactory() : unit =
        this.list <- BasicArrayListUtil.getInstance().getImmutableInstance()
        ()
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        this.list <- (new BasicArrayListD())
    
    static member getInstance() : ArtificialIntelligenceInterfaceFactoryInterfaceFactory =
        ArtificialIntelligenceInterfaceFactoryInterfaceFactory.SINGLETON
    
    abstract getInstanceFromCollection : hashtable: ABHashtable -> ArtificialIntelligenceInterfaceFactoryInterface
    default this.getInstanceFromCollection(hashtable: ABHashtable) : ArtificialIntelligenceInterfaceFactoryInterface =
        let mutable typeInteger : Integer = (box (hashtable.get((box (BasicAI.ID)))) :?> Integer)
        let mutable type_ : int = typeInteger.intValue()
        let mutable artificialIntelligenceInterfaceFactoryInterface : ArtificialIntelligenceInterfaceFactoryInterface = (box (this.list.objectArray.[type_ - 1]) :?> ArtificialIntelligenceInterfaceFactoryInterface)
        artificialIntelligenceInterfaceFactoryInterface
    
    abstract add : artificialIntelligenceInterfaceFactoryInterface: ArtificialIntelligenceInterfaceFactoryInterface -> unit
    default this.add(artificialIntelligenceInterfaceFactoryInterface: ArtificialIntelligenceInterfaceFactoryInterface) : unit =
        ignore (this.list.add(artificialIntelligenceInterfaceFactoryInterface))


