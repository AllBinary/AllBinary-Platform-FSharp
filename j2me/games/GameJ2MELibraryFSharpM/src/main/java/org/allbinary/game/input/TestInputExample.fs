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
type TestInputExample =
    [<DefaultValue(false)>] val mutable testValue : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TestInputExample.jclinitDone then
            TestInputExample.jclinitDone <- true
            TestInputExample.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract up : unit -> unit
    default this.up() : unit =
        ()
    
    abstract down : unit -> unit
    default this.down() : unit =
        ()
    
    abstract left : unit -> unit
    default this.left() : unit =
        this.testValue <- this.testValue + 1
    
    abstract right : unit -> unit
    default this.right() : unit =
        this.testValue <- this.testValue - 1
    
    abstract strafeLeft : unit -> unit
    default this.strafeLeft() : unit =
        ()
    
    abstract strafeRight : unit -> unit
    default this.strafeRight() : unit =
        ()
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        ()
    
    abstract paintThreed : graphics: Graphics -> unit
    default this.paintThreed(graphics: Graphics) : unit =
        ()
    interface TestInputInterface with
        member this.up() : unit = this.up()
        member this.down() : unit = this.down()
        member this.left() : unit = this.left()
        member this.right() : unit = this.right()
        member this.strafeLeft() : unit = this.strafeLeft()
        member this.strafeRight() : unit = this.strafeRight()
    interface PaintableInterface with
        member this.paint(jp0: Graphics) : unit = this.paint(jp0)
        member this.paintThreed(jp0: Graphics) : unit = this.paintThreed(jp0)


