/* ---- PRE ---- */
{v_precode}

/* PROC LIFEREG */

proc lifereg data = {v_data}();
class {v_class};
model {v_model} = {v_effects} {v_class} / {v_model_options};
{v_probplot};
{v_inset};
{v_output};
{v_by};
run;

/* ---- POST ---- */
{v_postcode}