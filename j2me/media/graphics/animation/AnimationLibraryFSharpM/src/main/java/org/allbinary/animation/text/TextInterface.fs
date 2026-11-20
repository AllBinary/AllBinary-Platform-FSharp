namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type TextInterface =
    abstract setTextWithOnMeasure : text: string * textChangeListener: TextChangeListener -> unit
    abstract getText : unit -> string
    abstract setText : text: string -> unit
    abstract getFontHeight : unit -> int
    abstract getWidth : unit -> int


