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
type CurrentlyPressedTouchButtonSingleton =
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_instance : CurrentlyPressedTouchButtonSingleton
    static member instance with get() : CurrentlyPressedTouchButtonSingleton = (CurrentlyPressedTouchButtonSingleton.jclinit(); CurrentlyPressedTouchButtonSingleton.jcell_instance) and set (jvalue: CurrentlyPressedTouchButtonSingleton) = (CurrentlyPressedTouchButtonSingleton.jclinit(); CurrentlyPressedTouchButtonSingleton.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CurrentlyPressedTouchButtonSingleton.jclinitDone then
            CurrentlyPressedTouchButtonSingleton.jclinitDone <- true
            CurrentlyPressedTouchButtonSingleton.jclinitBody()
    static member private jclinitBody() : unit =
        CurrentlyPressedTouchButtonSingleton.jcell_instance <- (new CurrentlyPressedTouchButtonSingleton())
        ()
    member this.jfields_CurrentlyPressedTouchButtonSingleton() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    static member getInstance() : CurrentlyPressedTouchButtonSingleton =
        CurrentlyPressedTouchButtonSingleton.instance
    
    new () as this =
        {  }
        then
            this.jfields_CurrentlyPressedTouchButtonSingleton()
    
    abstract size : unit -> int
    default this.size() : int =
        this.list.size()
    
    abstract removeAt : index: int -> TouchButtonInput
    default this.removeAt(index: int) : TouchButtonInput =
        (box (this.list.removeAt(index)) :?> TouchButtonInput)
    
    abstract remove : touchButtonInput: TouchButtonInput -> bool
    default this.remove(touchButtonInput: TouchButtonInput) : bool =
        this.list.remove(touchButtonInput)
    
    abstract get : index: int -> TouchButtonInput
    default this.get(index: int) : TouchButtonInput =
        (box (this.list.objectArray.[index]) :?> TouchButtonInput)
    
    abstract contains : touchButtonInput: TouchButtonInput -> bool
    default this.contains(touchButtonInput: TouchButtonInput) : bool =
        this.list.contains(touchButtonInput)
    
    abstract add : touchButtonInput: TouchButtonInput -> unit
    default this.add(touchButtonInput: TouchButtonInput) : unit =
        ignore (this.list.add(touchButtonInput))


