$(document).ready(function () {
   
    $(document).on("click", ".show-more-btn", function () {
        let parent = $("#parent-elem")
        let skipCount = $(parent).children().length;
        let productCount = $(".courses").attr("data-count");
        
        $.ajax({
            url: `courses/showMoreOrLess?skip=${skipCount}`,
            type: "Get",
            success: function (res) {
                $(parent).append(res)
                skipCount = $(parent).children().length;
                if (skipCount >= productCount) {
                    $(".show-more-btn").addClass("d-none")
                    $(".show-less-btn").removeClass("d-none")
                }
            }
        })
    })

});