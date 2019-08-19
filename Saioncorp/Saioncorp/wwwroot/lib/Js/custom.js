jQuery(document).ready(function ($) {

    $(function () {
        $('.customscrollbar').mCustomScrollbar({ axis: "y" });
    });

    $('.hbb-search').click(function () {
        $('.search-box').addClass('open');
    });

    $('.search-box a').click(function () {
        $('.search-box').removeClass('open');
    });

    $('.hbb-user').click(function () {
        $('.profile-box').addClass('open');
    });

    $('.hbb-mail').click(function () {
        $('.right-menu').addClass('right-menu-open');
    });

    $('.cbf-field-box').on('focusin', function () {
        $(this).parent().find('label').addClass('active');
    });

    $('.cbf-field-box').on('focusout', function () {
        if (!this.value) {
            $(this).parent().find('label').removeClass('active');
        }
    });

    $('.smu-row-btn').click(function () {
        $('.search-menu-user-btn-box').slideDown();
    });

    $('.top-nav-btn').click(function () {
        $('.menu-bar').addClass('right-menu-open');
    });
    $('.left-menu-btn').click(function () {
        $('.section-left-menu').addClass('left-menu-open');
    });

    $(' .header-popup-box i').click(function () {
        $('.header-popup-box').removeClass('open');
    });

    $('.side-box-close-btn').click(function () {
        $('.right-menu').removeClass('right-menu-open');
        $('.menu-bar').removeClass('right-menu-open');
        $('.section-left-menu').removeClass('left-menu-open');
    });

    $('.slsnl-down-arrow').click(function () {
        if ($(this).hasClass('active')) {
            $(this).removeClass('active');
            $(this).parent('a').removeClass('active');
            $(this).parents().siblings('ul').slideUp();
        }
        else {
            $(this).addClass('active');
            $(this).parent('a').addClass('active');
            $(this).parents().siblings('ul').slideDown();
        }
    });

    $('.section-left-menu').css('min-height', $('.section-right-content').height());

    $(window).resize(function () {
        $('.section-left-menu').css('min-height', $('.section-right-content').height())
    });

    $('body').click(function () {
        setInterval(function () { $('.section-left-menu').css('min-height', $('.section-right-content').height()); }, 500);

    });
});