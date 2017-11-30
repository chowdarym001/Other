(function($) {
    $(document).ready(function () {
        if (typeof Sitecore === 'undefined' || typeof Sitecore.PageModes === 'undefined') {
            $(".basic-3col-actions .cell .grid-x").each(function() {
                var numCells = this.children.length;
                this.className = this.className.replace("medium-up-3", "medium-up-" + numCells);;
            });
        }
    });
})(jQuery);