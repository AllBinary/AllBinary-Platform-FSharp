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
type RelativeRelationship =
    [<DefaultValue(false)>] val mutable typesAllowedList : BasicArrayList
    [<DefaultValue(false)>] val mutable x : int
    [<DefaultValue(false)>] val mutable y : int
    [<DefaultValue(false)>] val mutable z : int
    [<DefaultValue(false)>] static val mutable private jcell_NULL_RELATIVE_RELATIONSHIP : RelativeRelationship
    static member NULL_RELATIVE_RELATIONSHIP with get() : RelativeRelationship = (RelativeRelationship.jclinit(); RelativeRelationship.jcell_NULL_RELATIVE_RELATIONSHIP) and set (jvalue: RelativeRelationship) = (RelativeRelationship.jclinit(); RelativeRelationship.jcell_NULL_RELATIVE_RELATIONSHIP <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RelativeRelationship.jclinitDone then
            RelativeRelationship.jclinitDone <- true
            RelativeRelationship.jclinitBody()
    static member private jclinitBody() : unit =
        RelativeRelationship.jcell_NULL_RELATIVE_RELATIONSHIP <- (new RelativeRelationship(PointFactory.getInstance().ZERO_ZERO, BasicArrayListUtil.getInstance().getImmutableInstance()))
        ()
    
    new (point: GPoint, typesAllowedList: BasicArrayList) as this =
        {  }
        then
            this.jctor1(point, typesAllowedList)
    member this.jctor1(point: GPoint, typesAllowedList: BasicArrayList) : unit =
        this.x <- point.getX()
        this.y <- point.getY()
        this.z <- point.getZ()
        this.typesAllowedList <- typesAllowedList
        ()
    
    abstract getX : unit -> int
    default this.getX() : int =
        this.x
    
    abstract getY : unit -> int
    default this.getY() : int =
        this.y
    
    abstract getZ : unit -> int
    default this.getZ() : int =
        this.z
    
    abstract getTypesAllowedList : unit -> BasicArrayList
    default this.getTypesAllowedList() : BasicArrayList =
        this.typesAllowedList
    
    abstract setTypesAllowedList : typesAllowedList: BasicArrayList -> unit
    default this.setTypesAllowedList(typesAllowedList: BasicArrayList) : unit =
        this.typesAllowedList <- typesAllowedList


