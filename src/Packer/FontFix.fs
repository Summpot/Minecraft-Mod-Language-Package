
module FontFix 
    let replaceWithTwoCharactor (input : char) =
        match input with 
        |'\ue900'->"钅卢"
        |'\ue901' ->"钅杜"
        |'\ue902'->"钅喜"
        |'\ue903'->"钅波"
        |'\ue904'->"钅黑"
        |'\u9fcf'  ->"钅麦"
        |'\ue906'->"钅达"
        |'\ue907'->"钅仑"
        |'\u9fd4' ->"钅哥"
        |'\u9fed' ->"钅尔"
        |'\ue90a'->"钅夫"
        |'\ue90c'->"钅立"
        |'\u9fec' ->"石田"
        |'\u9feb' ->"奥气"
        |_->input.ToString()


