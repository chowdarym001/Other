(function ($) {
    $(document).ready(function () {
        var tabsPanel = ".tabs-panel";
        $(".verticalNav").each(function () {
            var vert = $(this);
            var vertTabs = vert.find(".accortabs-tabs ul")[0];
            $(vertTabs).attr("data-responsive-accordion-tabs", "accordion medium-accordion large-tabs");
            $(vertTabs).attr("data-deep-link", "true");
            $(vertTabs).attr("data-udpate-history", "true");
            $(vertTabs).attr("data-deep-link-smudge", "500");
            var tabPanels = vert.find(tabsPanel);
            tabPanels[0].className = $(tabsPanel)[0].className + " is-active";
            tabPanels.each(function (index) {
                var isActive = "";
                if (index === 0) {
                    isActive = " is-active";
                }
                var tabTitle = $(this).find("h1").text();
                var tabId = $(this).attr("id");
                var li = "<li class='tabs-title" + isActive + "'></li>";
                var newLi = $(li)[0];
                var newAnchor = "<a href='#" + tabId + "' " + (isActive === "" ? "" : " aria-selected='true'") + ">" + tabTitle + "</a>";
                newLi.append($(newAnchor)[0]);
                vertTabs.append(newLi);
            });
            Foundation.reflow($(vertTabs), 'responsive-accordion-tabs');
        });
    });
})(jQuery);