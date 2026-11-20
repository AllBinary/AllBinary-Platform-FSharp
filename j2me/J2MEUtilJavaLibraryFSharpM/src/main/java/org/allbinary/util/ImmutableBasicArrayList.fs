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
type ImmutableBasicArrayList =
    inherit BasicArrayListS
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImmutableBasicArrayList.jclinitDone then
            ImmutableBasicArrayList.jclinitDone <- true
            ImmutableBasicArrayList.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (name: string, size: int) as this =
        { inherit BasicArrayListS(size) }
        then
            this.jctor1(name, size)
    member this.jctor1(name: string, size: int) : unit =
        ()
        this.name <- name
        ()
    
    override this.add(e: obj) : bool =
        ForcedLogUtil.log(this.name, this)
        true
    
    override this.addAt(index: int, element: obj) : unit =
        ForcedLogUtil.log(this.name, this)
    
    override this.ToString() : string =
        this.name


