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
type PasswordValidator =
    inherit TextFieldItemValidator
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PasswordValidator.jclinitDone then
            PasswordValidator.jclinitDone <- true
            PasswordValidator.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (textFieldItem: ABTextFieldItem, min_: int, max_: int, allowOnEmpty: bool) =
        { inherit TextFieldItemValidator(textFieldItem, min_, max_, allowOnEmpty) }


