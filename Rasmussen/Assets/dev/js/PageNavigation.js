(function ($) {
    $(document).ready(function () {
        $(".tabs-panel").each(function () {
            if (this.id) {
                var h1 = $(this).find("h1");
                $(".page-nav ul").append("<li><a class='inline-link-arrow' href='#" + this.id + "'>" + h1.text() + "</a></li>");
            };
        });
        $("section").each(function () {
            if (this.id) {
                var h1 = $(this).find("h1");
                $(".page-nav ul").append("<li><a class='inline-link-arrow' href='#" + this.id + "'>" + h1.text() + "</a></li>");
            };
        });

        $(".page-nav ul li a").click(function () {
            var contentId = $(this).attr("href").replace("#", "");
            var selectedTab = $("#main-contents").find("#" + contentId);
            var tabComponent = $(selectedTab).closest(".verticalNav");

            if (tabComponent.length === 0) return;

            var aSelected = "aria-selected";
            var tabsTitle = "tabs-title";
            var tabsPanel = "tabs-panel";
            var isActive = " is-active";
            var tabs = "#tabs_" + tabComponent.attr("id");

            tabComponent.find(tabs + " li")
                .each(function () { this.className = tabsTitle });
            tabComponent.find(tabs + " li a")
                .each(function () {
                    var aId = $(this).attr("id").replace("-label", "");
                    if (aId === contentId) {
                        $(this).attr(aSelected, "true");
                        this.parentElement.className = tabsTitle + isActive;
                    } else {
                        $(this).removeAttr(aSelected);
                        this.parentElement.className = tabsTitle;
                    }
                });
            tabComponent.find(".tabs-content div").each(function() {
                this.className = $(this).attr("id") === contentId ? tabsPanel + isActive : tabsPanel;
            });

        });
    });
})(jQuery);