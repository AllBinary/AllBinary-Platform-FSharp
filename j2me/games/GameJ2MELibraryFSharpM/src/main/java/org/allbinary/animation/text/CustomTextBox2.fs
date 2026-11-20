namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type CustomTextBox2 =
    inherit CustomTextBox
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CustomTextBox2.jclinitDone then
            CustomTextBox2.jclinitDone <- true
            CustomTextBox2.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (cmdListener: CommandListener, label: string, text: string, maxSize: int, constraints: int, font: Font, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) as this =
        { inherit CustomTextBox(cmdListener, label, text, maxSize, constraints, font, backgroundBasicColor, foregroundBasicColor) }
        then
            this.jctor1(cmdListener, label, text, maxSize, constraints, font, backgroundBasicColor, foregroundBasicColor)
    member this.jctor1(cmdListener: CommandListener, label: string, text: string, maxSize: int, constraints: int, font: Font, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) : unit =
        ()
        this.getTextFieldItem().setFocus(true)
        ()


