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
type BasicColorArrayIndexer =
    [<DefaultValue(false)>] val mutable basicColorArray : BasicColor[]
    [<DefaultValue(false)>] val mutable circularIndexUtil : CircularIndexUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicColorArrayIndexer.jclinitDone then
            BasicColorArrayIndexer.jclinitDone <- true
            BasicColorArrayIndexer.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (basicColorArray: BasicColor[]) as this =
        {  }
        then
            this.jctor1(basicColorArray)
    member this.jctor1(basicColorArray: BasicColor[]) : unit =
        this.basicColorArray <- basicColorArray
        this.circularIndexUtil <- CircularIndexUtil.createInstance(this.basicColorArray.Length)
        ()
    
    abstract next : unit -> unit
    default this.next() : unit =
        ignore (this.circularIndexUtil.next())
    
    abstract get : unit -> BasicColor
    default this.get() : BasicColor =
        this.basicColorArray.[this.circularIndexUtil.getIndex()]
    
    abstract getBasicColorArray : unit -> BasicColor[]
    default this.getBasicColorArray() : BasicColor[] =
        this.basicColorArray


